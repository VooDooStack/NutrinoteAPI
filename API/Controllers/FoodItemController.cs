using Application.FoodItems;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [AllowAnonymous]
    public class FoodItemController : BaseApiController
    {
        private readonly IMediator Mediator;
        public FoodItemController(IMediator mediator)
        {

            Mediator = mediator;
        }

        [HttpPost("{id:Guid?}")]

        public async Task<IActionResult> UpdateOrCreateFoodItem(Guid? id, FoodItem foodItem)
        {
            if (id != null) foodItem.Id = id.Value;
            return Ok(await Mediator.Send(new UpdateOrCreate.Command { FoodItem = foodItem }));
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult> GetFoodItem(Guid id)
        {
            return Ok(await Mediator.Send(new Details.Command { Id = id }));
        }

        [HttpGet]
        public async Task<ActionResult<List<FoodItem>>> GetFoodItems(CancellationToken cancellationToken)
        {
            return Ok(await Mediator.Send(new List.command(), cancellationToken));
        }
    }
}