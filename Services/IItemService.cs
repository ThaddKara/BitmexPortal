using System.Collections.Generic;

namespace sp_bmexportal.Services
{
	public interface IItemService
	{
		object GetPosition(PositionRequest itemModel);
		void GetItems();
	}
}