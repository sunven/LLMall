using LLMall.Controllers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LLMall.Web.Host.Controllers
{
    public class AchievementController: LLMallControllerBase
    {
        public void UpLoad()
        {
            /*try
            {
                var Files = Request.Form.Files;
                long size = Files.Sum(f => f.Length);
                //size > 100MB refuse upload !
                if (size > 104857600)
                {
                    return Json(ResponseHelper.Error_Msg_Ecode_Elevel_HttpCode("files total size > 100MB , server refused !"));
                }

                List<string> filePathResultList = new List<string>();
                foreach (var file in Files)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    string filePath = hostingEnv.WebRootPath + @"\" + "Files" + @"\files\";
                    if (!Directory.Exists(filePath))
                    {
                        Directory.CreateDirectory(filePath);
                    }
                    fileName = DateTime.Now.ToString("yyMMddHHmmss") + "_" + Guid.NewGuid() + "." + fileName.Split('.')[1];
                    string fileFullName = filePath + fileName;
                    using (FileStream fs = System.IO.File.Create(fileFullName))
                    {
                        file.CopyTo(fs);
                        fs.Flush();
                    }
                    filePathResultList.Add($"/src/files/{fileName}");
                }
                string message = $"{files.Count} file(s) /{size} bytes uploaded successfully!";
                return Json(ResponseHelper.IsSuccess_Msg_Data_HttpCode(message, filePathResultList, filePathResultList.Count));

            }
            catch (Exception ex)
            {
                return null;
            }*/
        }
    }
}
