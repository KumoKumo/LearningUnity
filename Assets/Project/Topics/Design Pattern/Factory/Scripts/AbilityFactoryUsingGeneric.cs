using System;
using System.Linq.Expressions;

namespace ReflectionFactory
{
    /*
     * The Generic approach doesn't work well with the Factory design concept.
     * Client still need to know which Type to pass in so it kinda destroys the purpose of Factory.
     * Still keep this because the post in the link below is interesting.
     * https://devblogs.microsoft.com/premier-developer/dissecting-the-new-constraint-in-c-a-perfect-example-of-a-leaky-abstraction/
     * 
     */
    public static class AbilityFactoryUsingGeneric
    {
        public static T GetAbility<T>() where T : Ability, new() => new T();

    }

    //Fast Activator Solution
    public static class FastActivatorOfAbilityFactoryUsingGeneric<T> where T : Ability, new()
    {
        public static readonly Func<T> Create = DynamicModuleLambdaCompiler.GenerateFactory<T>();
    }
    
}

