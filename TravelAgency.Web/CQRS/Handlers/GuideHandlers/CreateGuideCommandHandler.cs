﻿using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TravelAgency.Web.CQRS.Commands.GuideCommands;

namespace TravelAgency.Web.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
            _context.Guides.Add(new Guide
            {
                GuideName = request.GuideName,
                GuideSurname = request.GuideSurname,
                GuideDescription = request.GuideDescription,
                ImageUrl = request.ImageUrl,
                InstagramUrl = request.InstagramUrl,
                TwitterUrl = request.TwitterUrl,
                Status = true
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }

    }
}
