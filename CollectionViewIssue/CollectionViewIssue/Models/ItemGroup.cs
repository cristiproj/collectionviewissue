using System.Collections.Generic;

namespace CollectionViewIssue.Models
{
    class ItemGroup: List<Item>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ItemGroup(string name, string description, List<Item> items) : base(items)
        {
            Name = name;
            Description = description;
        }
    }
}
