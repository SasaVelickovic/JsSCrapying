﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelDownloader_v2.Models.Novel
{
    public class NovelChapter_Data
    {
        public Guid GUID { get; set; } = Guid.Empty;
        public List<NovelChapter> Chapters { get; set; } = new List<NovelChapter>();
    }
}
