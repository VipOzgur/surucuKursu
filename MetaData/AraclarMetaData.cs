﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurucuKursu.Models;

public partial class AraclarMetaData
{
	[Key]
	public long Id { get; set; }

	[Required]
    public string Adı { get; set; } = null!;

    public string? Plaka { get; set; }
}