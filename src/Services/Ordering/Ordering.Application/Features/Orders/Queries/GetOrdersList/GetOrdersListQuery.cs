﻿using MediatR;

namespace Ordering.Application.Features.Orders.Queries.GetOrdersList
{
    public class GetOrdersListQuery : IRequest<List<OrderVM>>
    {
        public string UserName { get; set; } = null!;

        public GetOrdersListQuery(string userName)
        {
            UserName = userName;
        }
    }
}
