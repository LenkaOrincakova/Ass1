﻿using Ass1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ass1.Data
{
    interface IFamilyManager
    {
       
        bool AddAdultToFamily(Adult adultToAdd);

        IList<Adult> GetAdults();
        void RemoveAdult(Adult adult);
        // IList<Family> GetFamilies();
        //  bool AddFamily(Family toAdd);
        // bool RemoveFamily(Family toRemove);
        //bool AddAdultToFamily(Adult adultToAdd);//, Family familyToJoin);
    }
}
