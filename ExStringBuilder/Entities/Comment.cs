﻿using System;

namespace ExStringBuilder.Entities
{
    class Comment
    {
        public String Text { get; set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
