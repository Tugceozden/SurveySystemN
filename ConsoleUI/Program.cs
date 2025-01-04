
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

IParticipantDal participantDal = new InMemoryParticipantDal();
IParticipantService participantService = new ParticipantManager(participantDal);

Participant participantToAdd = new Participant { Name = "doğru" };
participantService.Add(participantToAdd);