using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerAPI.Factory.Drinks{
public interface iDrinks
{
    string getflavour();
    string getVolume();
   
   bool getDiet();
}}