﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaihoChatBotV3.Models
{

    [Serializable]
    public class TrendList
    {
        public string year;
        public string month;
        public string eqp_typ;
        public string accidenttype;
        public int count;

    }
}