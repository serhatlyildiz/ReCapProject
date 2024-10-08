﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal) 
        { 
            _rentalDal = rentalDal;
        }
        public IResult Update(Rental rental)
        {
            //business codes

            if (rental.ReturnDate != null)
            {
                //magic strings
                return new ErrorResult(Messages.RentalAdded);
            }
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalError);
        }
    }
}
