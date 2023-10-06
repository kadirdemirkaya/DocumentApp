using DocumentConsumeForm.Enums;
using System;

namespace DocumentConsumeForm.Files
{
    public static class FilesCreate
    {
        public static bool FileCreate(string fileTypes,string data,string path)
        {
            FileTypes selectedFileType;
            bool result = false;
            if(Enum.TryParse(fileTypes, out selectedFileType))
            {
                switch(selectedFileType)
                {
                    case FileTypes.Pdf:
                        result = FileTypesCreate.FileTypesCreate.FileTypeCreate.CreatePdf(data, path);
                        return result;
                    case FileTypes.Json:
                        result = FileTypesCreate.FileTypesCreate.FileTypeCreate.CreateJson(data, path);
                        return result;
                    case FileTypes.Text:
                        result = FileTypesCreate.FileTypesCreate.FileTypeCreate.CreateText(data, path);
                        return result;
                }
            }
            return false;
        }
    }

   
}
