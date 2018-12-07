using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses {
    public class Family {
        private List<Person> members;
        public Family () {
            this.members = new List<Person> ();
        }
        public List<Person> Members {
            get { return this.members; }
            set { this.members = value; }
        }
        public void AddMember (Person member) {
            members.Add (member);
        }
        public Person GetOldestMember () {
            Person oldestMember = new Person ();
            foreach (var m in Members) {
                if (m.Age >= oldestMember.Age) {
                    oldestMember = m;
                }
            }
            return oldestMember;
        }
        public List<Person> GetMembersOlderThan (int greaterThan) {
            List<Person> oldestMembers = new List<Person> ();
            foreach (var m in Members) {
                if (m.Age > greaterThan) {
                    oldestMembers.Add (m);
                }
            }
            return oldestMembers;
        }

    }
}