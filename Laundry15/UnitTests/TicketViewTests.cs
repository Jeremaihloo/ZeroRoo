using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laundry.LibCore.Print;
using Laundry.LibCore.Repository;
using Laundry.LibCore.Print.Templates;
using System.Drawing;

namespace UnitTests
{
    [TestClass]
    public class TicketViewTests
    {
        [TestMethod]
        public void Test()
        {
            var rep = new LaundryRepository();
            var ticket = rep.All()[3];
            IPrintTemplate template = new TicketTemplate(ticket);
            Image bitmap = new Bitmap(224, 600);
            Graphics g = Graphics.FromImage(bitmap);
            PrintDrawer drawer = new PrintDrawer();
            drawer.Draw(template, bitmap.Size, g, null);
            bitmap.Save("tmp.jpg");
        }
    }
}
