﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Platformus.Barebone;
using Platformus.Forms.Data.Abstractions;
using Platformus.Forms.Data.Models;
using Platformus.Globalization.Backend.ViewModels;

namespace Platformus.Forms.Backend.ViewModels.Fields
{
  public class CreateOrEditViewModelMapper : ViewModelFactoryBase
  {
    public CreateOrEditViewModelMapper(IHandler handler)
      : base(handler)
    {
    }

    public Field Map(CreateOrEditViewModel createOrEdit)
    {
      Field field = new Field();

      if (createOrEdit.Id != null)
        field = this.handler.Storage.GetRepository<IFieldRepository>().WithKey((int)createOrEdit.Id);

      else field.FormId = createOrEdit.FormId;

      field.FieldTypeId = createOrEdit.FieldTypeId;
      field.Position = createOrEdit.Position;
      return field;
    }
  }
}