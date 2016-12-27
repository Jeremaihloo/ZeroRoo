/*****************************************************
 * 本类库的核心系 AderTemplates
 * (C) Andrew Deren 2004
 * http://www.adersoftware.com
 *****************************************************/

#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion
using ZeroRoo.Laughing;

namespace ZeroRoo.Laughing
{
    public class TagParser
    {
        List<Element> elements;

        public TagParser(List<Element> elements)
        {
            this.elements = elements;
        }

        public List<Element> CreateHierarchy()
        {
            List<Element> result = new List<Element>();

            for (int index = 0; index < elements.Count; index++)
            {
                Element elem = elements[index];

                if (elem is Text)
                    result.Add(elem);
                else if (elem is Expression)
                    result.Add(elem);
                else if (elem is Tag)
                {
                    result.Add(CollectForTag((Tag)elem, ref index));
                }
                else if (elem is TagClose)
                {
                    throw new ParseException("Close tag for " + ((TagClose)elem).Name + " doesn't have matching start tag.", elem.Line, elem.Col);
                }
                else
                    throw new ParseException("Invalid element: " + elem.GetType().ToString(), elem.Line, elem.Col);
            }

            return result;
        }

        private Tag CollectForTag(Tag tag, ref int index)
        {
            if (tag.IsClosed) // if self-closing tag, do not collect inner elements
            {
                return tag;
            }

            if (string.Compare(tag.Name, "if", true) == 0)
            {
                tag = new TagIf(tag.Line, tag.Col, tag.AttributeValue("test"));
            }

            Tag collectTag = tag;

            for (index++; index < elements.Count; index++)
            {
                Element elem = elements[index];

                if (elem is Text)
                    collectTag.InnerElements.Add(elem);
                else if (elem is Expression)
                    collectTag.InnerElements.Add(elem);
                else if (elem is Tag)
                {
                    Tag innerTag = (Tag)elem;
                    if (string.Compare(innerTag.Name, "else", true) == 0)
                    {
                        if (collectTag is TagIf)
                        {
                            ((TagIf)collectTag).FalseBranch = innerTag;
                            collectTag = innerTag;
                        }
                        else
                            throw new ParseException("else tag has to be positioned inside of if or elseif tag", innerTag.Line, innerTag.Col);

                    }
                    else if (string.Compare(innerTag.Name, "elseif", true) == 0)
                    {
                        if (collectTag is TagIf)
                        {
                            Tag newTag = new TagIf(innerTag.Line, innerTag.Col, innerTag.AttributeValue("test"));
                            ((TagIf)collectTag).FalseBranch = newTag;
                            collectTag = newTag;
                        }
                        else
                            throw new ParseException("elseif tag is not positioned properly", innerTag.Line, innerTag.Col);
                    }
                    else
                        collectTag.InnerElements.Add(CollectForTag(innerTag, ref index));
                }
                else if (elem is TagClose)
                {
                    TagClose tagClose = (TagClose)elem;
                    if (string.Compare(tag.Name, tagClose.Name, true) == 0)
                        return tag;

                    throw new ParseException(string.Format("Close tag for {0} doesn't have matching start tag. Line:{1} Col:{2}", tagClose.Name, tagClose.Line, tagClose.Col),
                        elem.Line, elem.Col);
                }
                else
                    throw new ParseException(string.Format("Invalid element: {0} Line:{1} Col:{2}", elem.GetType().ToString(), elem.Line, elem.Col), elem.Line, elem.Col);

            }

            throw new ParseException(string.Format("Start tag: {0} does not have matching end tag. Line:{1} Col:{2}", tag.Name, tag.Line, tag.Col), tag.Line, tag.Col);

        }

    }
}
