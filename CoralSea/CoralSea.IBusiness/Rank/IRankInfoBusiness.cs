﻿using CoralSea.Model.Rank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoralSea.IBusiness.Rank
{
    public interface IRankInfoBusiness
    {
        RankInfoModel GetRankInfo(int id);
    }
}
