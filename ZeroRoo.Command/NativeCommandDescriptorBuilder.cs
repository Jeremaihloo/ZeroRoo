using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeroRoo.Commands
{
    public class NativeCommandDescriptorBuilder
    {
        public string[] NativeCommandDirectory { get; set; }

        public string[] NativeCommandFileNames { get; set; }

        public NativeCommandDescriptorBuilder(string[] nativeCommandDirectory, string[] nativeCommandFileNames)
        {
            this.NativeCommandDirectory = nativeCommandDirectory;
            this.NativeCommandFileNames = nativeCommandFileNames;
        }

        public NativeCommandDescriptor Build(string fileName)
        {
            var fileArr = fileName.Split('.');
            return new NativeCommandDescriptor()
            {
                FileName = fileName,
                Name = string.Join("", fileArr.Take(fileArr.Count() - 1).ToString())
            };
        }

        public NativeCommandDescriptor[] GetNativeCommandDescriptors()
        {
            var descriptors = new List<NativeCommandDescriptor>();

            var filesList = new List<string>();
            foreach(var item in this.NativeCommandDirectory)
            {
                var files = Directory.GetFiles(item);
                filesList.AddRange(files);
            }
            filesList.AddRange(this.NativeCommandFileNames);

            foreach(var item in filesList)
            {
                descriptors.Add(this.Build(item));
            }
            return descriptors.ToArray();
        }
    }
}
