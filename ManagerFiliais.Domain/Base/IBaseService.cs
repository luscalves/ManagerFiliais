﻿using FluentValidation;
using System.Collections.Generic;

namespace ManagerFiliais.Domain.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void AttachObject(object obj);

        TOutputModel Add<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;

        void Delete(int id);

        IEnumerable<TOutputModel> Get<TOutputModel>(bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

        TOutputModel GetById<TOutputModel>(int id, bool tracking = true, IList<string>? includes = null)
            where TOutputModel : class;

        TOutputModel Update<TInputModel, TOutputModel, TValidator>(TInputModel inputModel)
            where TValidator : AbstractValidator<TEntity>
            where TInputModel : class
            where TOutputModel : class;
    }
}