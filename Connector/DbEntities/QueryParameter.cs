using System;
using System.Collections.Generic;

namespace Connector.DbEntities;

public partial class QueryParameter
{
    public int Id { get; set; }

    public int? ReqId { get; set; }

    public int? ApiId { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public bool? IsActive { get; set; }

    public virtual ApiDetail IdNavigation { get; set; } = null!;

    public virtual ApiRequest? Req { get; set; }
}
