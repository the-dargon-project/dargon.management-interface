using System;

namespace Dargon.Management.Models {
   public class MobModel {
      private readonly Guid guid;
      private readonly string name;

      public MobModel(Guid guid, string name) {
         this.guid = guid;
         this.name = name;
      }

      public Guid Guid { get { return guid; } }
      public string Name { get { return name; } }
   }
}