using System.ComponentModel.DataAnnotations;
using Application.Models.Employees;
using Application.Models.Occurrences;

namespace Application.Models.Attendances;

public class AttendanceModel
{
    public int Id { get; set; }
    public int EmployeeId { get; set; }
    [UIHint("AttendanceEmployeeEditor")] [Required]
    public EmployeeModel? Employee { get; set; }
    public int OccurrenceId { get; set; }
    [UIHint("AttendanceOccurrenceEditor")] [Required]
    public OccurrenceModel? Occurrence { get; set; }
    [MaxLength(500)]
    public string? Description { get; set; }
    [UIHint("DatePickerGridEditor")] [Required]
    public DateTime OccurrenceStartDate { get; set; }
    [UIHint("DatePickerGridEditor")] [Required]
    public DateTime OccurrenceEndDate { get; set; }
}