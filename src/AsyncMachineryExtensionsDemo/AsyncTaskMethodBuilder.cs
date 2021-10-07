using System.Threading.Tasks;
using AsyncMachineryExtensionsDemo;

namespace System.Runtime.CompilerServices
{
    public class AsyncTaskMethodBuilder
    {
        public AsyncTaskMethodBuilder()
        { }

        public Task Task
        {
            get
            {
                // Obtém a tarefa para esse construtor.
                return Task.CompletedTask;
            }
        }

        public static AsyncTaskMethodBuilder Create() => new();

        public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : INotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
            // Programa para que a máquina de estado prossiga para a próxima
            // ação quando o awaiter especificado for concluído.
        }

        public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
            where TAwaiter : ICriticalNotifyCompletion
            where TStateMachine : IAsyncStateMachine
        {
            // Programa para que a máquina de estado prossiga para a próxima ação
            // quando o awaiter especificado for concluído. Esse método pode ser chamado de código parcialmente confiável.
        }

        public void SetException(Exception e)
        {
            // Marca a tarefa como com falha e associa a exceção especificada à tarefa.
        }

        public void SetResult()
        {
            // Marca a tarefa como concluída com êxito.
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            // Associa o construtor com a máquina de estado especificada.
        }

        public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
        {
            // Começa a execução do construtor com a máquina de estado associada.

            new CompletedStateMachine().MoveNext();
            //stateMachine.MoveNext();
        }
    }
}
