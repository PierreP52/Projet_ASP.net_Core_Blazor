using System;
using System.Collections.Generic;

namespace BlazorServerApp.Models;

public partial class Message
{
    public string Id { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Message1 { get; set; } = null!;
}
