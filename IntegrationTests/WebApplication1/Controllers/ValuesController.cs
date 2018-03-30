using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ValuesController : Controller
    {
	    public int Add([FromQuery]int a,[FromQuery] int b)
	    {
		    return a + b;
	    }
    }
}
