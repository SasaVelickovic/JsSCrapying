﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDownloader_v2.Models.Novel
{
    public class Novel_Data : TOCBase
    {
        public Guid GUID { get; set; } = Guid.Empty;
        public byte[] Cover { get; set; } = new byte[0];
        public int DownloadedChapterCount { get; set; } = 0;
        public bool CheckUpdate { get; set; } = true;
    }
}
