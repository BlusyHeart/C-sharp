using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly List<IDecoration> _decorations;

        public DecorationRepository()
        {
            _decorations = new List<IDecoration>();
        }

        public IReadOnlyCollection<IDecoration> Models => _decorations.AsReadOnly();

        public void Add(IDecoration model) => _decorations.Add(model);

        public IDecoration FindByType(string type) => _decorations.FirstOrDefault(d => d.GetType().Name == type);

        public bool Remove(IDecoration model) => _decorations.Remove(model);
        
    }
}
