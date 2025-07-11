﻿using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_net9.Application.FactorDetailFeature.Command.AddCommand
{
    public class AddFactorDetailCommandValidation : AbstractValidator<AddFactorDetailCommand>
    {
        public AddFactorDetailCommandValidation()
        {
            RuleFor(x => x.ProductDescription)
                .MaximumLength(50).WithMessage("توضیحات نباید بیشتر از 50 کاراکتر باشد.");

            RuleFor(x => x.UnitPrice)
                .NotEmpty().WithMessage("قیمت واحد اجباری است.")
                .GreaterThan(0).WithMessage("قیمت واحد باید بیشتر از صفر باشد.");

            RuleFor(x => x.Count)
                .NotEmpty().WithMessage("تعداد اجباری است.")
                .GreaterThan(0).WithMessage("تعداد باید بیشتر از صفر باشد.");

        }
    }
}
