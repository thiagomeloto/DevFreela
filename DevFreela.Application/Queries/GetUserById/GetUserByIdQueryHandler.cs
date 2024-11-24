﻿using DevFreela.Application.ViewModels;
using DevFreela.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Queries.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, UserViewModel>
    {
        private readonly DevFreelaDbContext _dbContext;
        public GetUserByIdQueryHandler(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<UserViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(p => p.Id == request.Id);

            if (user == null)            
                return null;            

            return new UserViewModel(user.FullName, user.Email);
        }
    }
}
