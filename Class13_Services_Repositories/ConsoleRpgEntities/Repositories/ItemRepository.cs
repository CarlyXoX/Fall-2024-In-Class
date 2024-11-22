using ConsoleRpgEntities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleRpgEntities.Models.Equipments;

namespace ConsoleRpgEntities.Repositories
{
    public class ItemRepository
    {
        private readonly GameContext _context;

        public ItemRepository(GameContext context)
        {
            _context = context;
        }

        // CREATE
        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }


        // READ
        public Item GetItemById(int id)
        {
            return _context.Items.FirstOrDefault(i => i.Id == id);
        }

        // UPDATE
        public void UpdateItem(Item item)
        {
            _context.Items.Update(item);
            _context.SaveChanges();
        }

        // UPDATE - ensure we are updating the item in the database
        public void UpdateItemAttack(int id, int attack)
        {
            // MUST get existing item from database to update it
            var item = GetItemById(id);

            item.Attack = attack;
            UpdateItem(item);
        }

        // DELETE
        public void DeleteItem(Item item)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
        }

        // DELETE - ensure we are deleting the item in the database
        public void DeleteItemById(int id)
        {
            // MUST get existing item from database to delete it
            var item = GetItemById(id);
            DeleteItem(item);
        }
    }
}
