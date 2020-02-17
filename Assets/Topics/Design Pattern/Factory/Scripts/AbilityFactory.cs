﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ReflectionFactory
{

    public static class AbilityFactory
    {
        private static Dictionary<string, Type> abilitiesByName;
        private static bool IsInitialized => abilitiesByName != null;
        public static void InitializeAbilityFactory()
        {
            //Not gonna do anything if not initialized already
            if (IsInitialized)
                return;

            /* 
             * Assembly.GetAssembly(Type) Method
             * Gets the currently loaded assembly in which the specified type is defined
             */
            var abilityTypes = Assembly.GetAssembly(typeof(Ability)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Ability)));

            abilitiesByName = new Dictionary<string, Type>();

            foreach (var type in abilityTypes)
            {
                var tempEffect = Activator.CreateInstance(type) as Ability;
                abilitiesByName.Add(tempEffect.Name, type);
            }
        }

        public static Ability GetAbility(string abilityType)
        {
            InitializeAbilityFactory();

            if (abilitiesByName.ContainsKey(abilityType))
            {
                Type type = abilitiesByName[abilityType];
                var ability = Activator.CreateInstance(type) as Ability;
                return ability;
            }

            return null;
        }

        internal static IEnumerable<string> GetAbilityNames()
        {
            InitializeAbilityFactory();
            return abilitiesByName.Keys;
        }
    }
}


