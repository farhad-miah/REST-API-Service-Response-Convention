using Domain.ServiceResponse;
using Model.Supplier;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain;

public interface ISupplierService
{
    Task<ServiceResponse<List<Supplier>>> GetSuppliers();

    Task<ServiceResponse<Supplier>> GetSupplier(Guid id);

    Task<ServiceResponse<Supplier>> InsertSupplier(Supplier supplier);

    Task<ServiceResponse<bool>> DeleteSupplier(Guid id);
}