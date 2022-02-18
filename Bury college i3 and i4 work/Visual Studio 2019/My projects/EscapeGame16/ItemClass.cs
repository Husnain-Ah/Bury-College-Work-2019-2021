using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeGame16
{
    class ItemClass
    {
        protected string ItemName { get; set; }
        protected string ItemDescription { get; set; }
        
        public ItemClass()
        {
            ItemName = "Item 1";
            ItemDescription = "description";
        }

        public string  getItemDetails()
        {
            return ("This is a " + ItemName + " " + ItemDescription + ".");
        }

       
        }

    class Key : ItemClass
    {
        private string Colour { get; set; }

        public Key()
        {
            ItemName = "Key 1";
            ItemDescription = "This is a key that can be used to open a door";
            Colour = "blue";
        }

        public Key(string name, string description = "This is a key that can be used to open a door", string colour = "red")
        {
            ItemName = name;
            ItemDescription = description;
            Colour = colour;
        }

        public string getKeyDetails()
        {
            return ("This is a " + Colour + " " + ItemName + ". " + ItemDescription);
        }
    }

        
}
