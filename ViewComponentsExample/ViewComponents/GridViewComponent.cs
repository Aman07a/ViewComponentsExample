using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;

namespace ViewComponentsExample.ViewComponents
{
	public class GridViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(PersonGridModel grid)
		{
			// Invoked a partial view: Views/Shared/Components/Grid/Default.cshtml
			return View("Sample", grid);
		}
	}
}
