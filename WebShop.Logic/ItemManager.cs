using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShop.Logic
{
    public class ItemManager
    {

        private int currentId;
        private List<Item> Items;

        public ItemManager()
        {
            Items = new List<Item>();
            currentId = 1;
        }
        public List<Item> GetAll() //lietotaju saraksts
        {
            return Items; // bus gatavs saraksts ar lietotajiem
        }
        public Item CreateNew(Item item) // lai izveidotu jaunu lietotāju
        {
            item.Id = currentId;
            Items.Add(item);
            currentId++;

            return item;
        }
        public void Delete(int id) // lietotāju dzēšana
        {
            var item = Items.Find(u => u.Id == id);
            Items.Remove(item);
        }
        public Item Get(int id)
        {
            var item = Items.Find(u => u.Id == id);
            return item;
        }

        public void Update(Item item)
        {

            var currentItem = Items.Find(u => u.Id == item.Id);
            // atjanot īpašības
            currentItem.CategoryId = item.CategoryId;
            currentItem.Description = item.Description;
            currentItem.Id = item.Id;
            currentItem.Photo = item.Photo;
            currentItem.Price = item.Price;
            currentItem.Title = item.Title;
        }
    } 
       







        //STUB data
        // dummy data 
        public void Seed()
        {
            Users.Add(new User()
            {
                Id = 1,
                Email = "Name 1"
            });
            Users.Add(new User()
            {
                Id = 2,
                Email = "Name 2"
            });

        }
    }
}

    }
}
