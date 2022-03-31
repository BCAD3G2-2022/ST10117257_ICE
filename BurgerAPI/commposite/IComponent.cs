using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerAPI.commposite
{

    public interface IComponent
    {
        public string getBurgerPart();

    }
}