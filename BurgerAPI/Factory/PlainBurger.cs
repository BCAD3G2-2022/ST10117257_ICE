using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerAPI.Factory{
public class PlainBurger : iBurger
{
    public string getBun()
    {
        return "wheat";
    }

    public string getPatty()
    {
        return "beef";
    }
}}