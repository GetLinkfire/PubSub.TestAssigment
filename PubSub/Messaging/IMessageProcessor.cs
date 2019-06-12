using System.Threading.Tasks;

namespace Messaging
{
	public interface IMessageProcessor<T>
	{
		Task ProcessMessageAsync(T message);
	}
}
