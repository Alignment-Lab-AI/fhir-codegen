// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The current status of the task.
  /// </summary>
  public static class TaskStatusCodes
  {
    /// <summary>
    /// The potential performer has agreed to execute the task but has not yet started work.
    /// </summary>
    public static readonly Coding Accepted = new Coding
    {
      Code = "accepted",
      Display = "Accepted",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task was not completed.
    /// </summary>
    public static readonly Coding Cancelled = new Coding
    {
      Code = "cancelled",
      Display = "Cancelled",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task has been completed.
    /// </summary>
    public static readonly Coding Completed = new Coding
    {
      Code = "completed",
      Display = "Completed",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task is not yet ready to be acted upon.
    /// </summary>
    public static readonly Coding Draft = new Coding
    {
      Code = "draft",
      Display = "Draft",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task should never have existed and is retained only because of the possibility it may have used.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task was attempted but could not be completed due to some error.
    /// </summary>
    public static readonly Coding Failed = new Coding
    {
      Code = "failed",
      Display = "Failed",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task has been started but is not yet complete.
    /// </summary>
    public static readonly Coding InProgress = new Coding
    {
      Code = "in-progress",
      Display = "In Progress",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task has been started but work has been paused.
    /// </summary>
    public static readonly Coding OnHold = new Coding
    {
      Code = "on-hold",
      Display = "On Hold",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task is ready to be performed, but no action has yet been taken.  Used in place of requested/received/accepted/rejected when request assignment and acceptance is a given.
    /// </summary>
    public static readonly Coding Ready = new Coding
    {
      Code = "ready",
      Display = "Ready",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// A potential performer has claimed ownership of the task and is evaluating whether to perform it.
    /// </summary>
    public static readonly Coding Received = new Coding
    {
      Code = "received",
      Display = "Received",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The potential performer who claimed ownership of the task has decided not to execute it prior to performing any action.
    /// </summary>
    public static readonly Coding Rejected = new Coding
    {
      Code = "rejected",
      Display = "Rejected",
      System = "http://hl7.org/fhir/task-status"
    };
    /// <summary>
    /// The task is ready to be acted upon and action is sought.
    /// </summary>
    public static readonly Coding Requested = new Coding
    {
      Code = "requested",
      Display = "Requested",
      System = "http://hl7.org/fhir/task-status"
    };
  };
}