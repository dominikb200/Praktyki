using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections.Generic;
using ProgramDoTestu;
using System.Threading.Tasks;

namespace ProgramDoTestu.Tests
{
    [TestClass()]
    public class ProgramTests
    {

        [TestMethod()]
        public void AddTaskTest()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("TestTask\n2023-12-31 12:00:00\n"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);

                    Program.AddTask();

                    var tasks = Program.tasks;
                    Assert.AreEqual(1, tasks.Count);
                    Assert.AreEqual("TestTask", tasks[0].Name);
                    Assert.AreEqual("WAITING", tasks[0].Status);
                }
            }
        }


        [TestMethod()]
        public void RemoveTaskTest()
        {
            using (var sw = new StringWriter())
            {
                using (var sr = new StringReader("TestTask"))
                {
                    Console.SetOut(sw);
                    Console.SetIn(sr);
                    Program.RemoveTask();
                }
            }
            var tasks = Program.tasks;
            Assert.AreEqual(0, tasks.Count);
        }

        [TestMethod()]
        public void RunTasksTest()
        {
            for (int i = 0; i < 10; i++)
            {
                using (var sw = new StringWriter())
                {
                    using (var sr = new StringReader("TestTask\n2023-09-31 12:00:00\n"))
                    {
                        Console.SetOut(sw);
                        Console.SetIn(sr);

                        Program.AddTask();

                    }
                }
            }
            System.Threading.Thread.Sleep(10000);
            var tasks = Program.tasks;
            foreach(var task in tasks)
            {
                if(task.Status != "DONE")
                {
                    Assert.Fail();
                }
            }
            return;

        }
    }
}
