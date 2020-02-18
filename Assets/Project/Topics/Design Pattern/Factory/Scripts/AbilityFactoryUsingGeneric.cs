using System;
using System.Linq.Expressions;

namespace ReflectionFactory
{
    /*
     * Normal Generic Factory Implementation
     * It is not encouraged to use this factory because of 
     * performance and correctness issues as being described in the link below
     * 
     * https://devblogs.microsoft.com/premier-developer/dissecting-the-new-constraint-in-c-a-perfect-example-of-a-leaky-abstraction/
     * 
     */
    public static class AbilityFactoryUsingGeneric
    {
        public static T GetAbility<T>() where T : Ability, new() => new T();

    }

    //Fast Activator Solution
    public static class FastActivatorOfAbilityFactoryUsingGeneric<T> where T : new()
    {
        public static readonly Func<T> Create = DynamicModuleLambdaCompiler.GenerateFactory<T>();
    }
    
}

