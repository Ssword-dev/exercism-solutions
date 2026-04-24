static class Badge
{
    public static string Print(int? id, string name, string? department) {
        department ??= "OWNER";
        
        var idPart = id is null ? "" : $"[{id}]" + " - ";
        var departmentPart = " - " + department.ToUpper();
        return $"{idPart}{name}{departmentPart}";
    }
}
