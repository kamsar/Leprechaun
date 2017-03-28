﻿namespace Leprechaun.Filters.Exclusions
{
	internal static class PathTool
	{
		internal static string EnsureTrailingSlash(string path)
		{
			if (path.EndsWith("/")) return path;
			return path + "/";
		}
	}
}
