using System;
   
namespace Northwind.Infrastructure.CslaBaseTypes
{
  [Serializable]
  public abstract class BusinessBase<T> : Csla.BusinessBase<T> where T : Csla.BusinessBase<T>
  {

  }
}
