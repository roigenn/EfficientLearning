﻿using EfLearning.Core.EntitiesHelper;
using EfLearning.Core.Users;
using System;

namespace EfLearning.Core.Announcements
{
    public class Comment : RootEntity<int>, ICreationTime
    {
        public int AnnouncementId { get; set; }
        public virtual Announcement Announcement { get; set; }
        public DateTime CreationTime { get; set; }

        public int UserId { get; set; }
        public virtual AppUser User { get; set; }

    }
}
