namespace INN8.Domain.Models.SBSModels.SBSHttpClientModel.Client.ClientModels;

using System;
using System.Collections.Generic;

public class SearchResult
{
  public Client Client { get; set; }
  public TypeCode TypeCode { get; set; }
  public PrimaryAddress PrimaryAddress { get; set; }
  public string Forename2 { get; set; }
  public string Forename3 { get; set; }
  public string AltSurname { get; set; }
  public string AbnNumber { get; set; }
  public DateTime DateOfBirth { get; set; }
  public Gender Gender { get; set; }
  public InvestorType InvestorType { get; set; }
  public bool WrapIndicator { get; set; }
  public List<ClientExternalReference> ClientExternalReferences { get; set; }
  public EntityType EntityType { get; set; }
  public Status Status { get; set; }
}
