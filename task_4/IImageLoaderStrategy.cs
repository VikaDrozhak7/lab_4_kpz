﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace task_4
{


    public interface IImageLoaderStrategy
    {
        Image Load(string href);
    }
}