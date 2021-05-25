using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class LoginService
    {
        public string[] GetLoginIds()
        {
            return new string[]
            {
                "pencil",
                "flower",
                "icecream",
                "basketball",
                "orange",
                "cat_team3"
            };
        }

        public string GetLoginUserFromId(string id)
        {
            //switch name to convert from object to name
            string name = "";
            switch (id)
            {
                case "pencil":
                    name = "Charlie123";
                    break;
                case "flower":
                    name = "Jackie";
                    break;
                case "icecream":
                    name = "Alex";
                    break;
                case "basketball":
                    name = "Logan";
                    break;
                case "orange":
                    name = "Murphy";
                    break;
                case "cat_team3":
                    name = "team3";
                    break;
            }
            return name;
        }
    }
}
