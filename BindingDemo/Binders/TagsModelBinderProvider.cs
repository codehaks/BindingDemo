﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BindingDemo.Binders
{
    public class TagsModelBinderProvider:IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(IEnumerable<string>))
            {
                var binder = new BinderTypeModelBinder(typeof(TagsModelBinder));

                return binder;
            }

            return null;
        }
    }
}
