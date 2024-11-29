using System;
using System.IO;
using System.Xml.Linq;

namespace CSLWebServer{
    public static class xmlHandler{
        public static void saveXML(XElement xml,string fileName){
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"CSLWebServer");
            Directory.CreateDirectory(folderPath);

            string filePath = Path.Combine(folderPath,fileName);
            xml.Save(filePath);
        }
    }
}