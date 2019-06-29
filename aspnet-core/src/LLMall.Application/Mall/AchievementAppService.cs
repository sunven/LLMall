using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Castle.Core.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace LLMall.Mall
{
    public class AchievementAppService : IAchievementAppService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILogger _logger;

        public AchievementAppService(IHttpContextAccessor httpContext, IHostingEnvironment hostingEnvironment,
            ILogger logger)
        {
            _httpContext = httpContext;
            _hostingEnvironment = hostingEnvironment;
            _logger = logger;
        }

        public List<string> UpLoad()
        {
            var files = _httpContext.HttpContext.Request.Form.Files;
            var size = files.Sum(f => f.Length);
            if (size > 104857600)
            {
                //size > 100MB refuse upload !
                throw new Exception("size > 100MB refuse upload");
            }

            var filePathResultList = new List<string>();
            foreach (var file in files)
            {
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                var dirPath = "\\uploadfiles\\" + DateTime.Now.ToString("yyyyMM") + "\\";
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(_hostingEnvironment.WebRootPath + dirPath);
                }

                fileName = DateTime.Now.ToString("yyyyMMddHHmmss") + "_" + fileName;
                var fileFullName = _hostingEnvironment.WebRootPath + dirPath + fileName;
                using (var fs = File.Create(fileFullName))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }

                filePathResultList.Add((dirPath + fileName).Replace("\\","/"));
            }

            return filePathResultList;
        }
    }
}