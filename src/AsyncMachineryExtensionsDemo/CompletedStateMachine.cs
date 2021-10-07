using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AsyncMachineryExtensionsDemo
{
    public class CompletedStateMachine : IAsyncStateMachine
    {
        public void MoveNext()
        {
            //Task.CompletedTask.GetAwaiter().GetResult();
            Task.Run(() => Console.WriteLine("Intercepted by statemachine")).GetAwaiter().GetResult();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new NotImplementedException();
        }
    }
}
