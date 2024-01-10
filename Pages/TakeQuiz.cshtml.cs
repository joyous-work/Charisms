using Charisms_2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Charisms_2.Pages
{

    public class TakeQuizModel : PageModel
    {
        public Prompt[] ShuffledPrompts = default!;

        public string TakeQuiz_Message = "Responses are required for every statement. Please check before submitting.";

        public TakeQuizModel()
        {
        }

        // Page refresh will show message from previous post, does not create a new page unlike get
        public void OnGet(string? mssg)
        {
            // remember to clear stale message if no message to display
            if (!String.IsNullOrEmpty(mssg))
            {
                TakeQuiz_Message = mssg;
            }
            ShuffledPrompts = CharismsContext.Prompts;
            CharismsContext.rng.Shuffle<Prompt>(ShuffledPrompts);   //only one shuffle per quiz
        }

        public IActionResult OnPost(string nq_name, int[] nq_pids, int[] nq_answers)
        {
            if (!ModelState.IsValid)
            {
                // can't initialize here, it'll become null in OnGet
                // TakeQuiz_Message = "Something went wrong. Please take a new quiz.";
                return RedirectToAction("Get", new { mssg = "Something went wrong. Please take a new quiz." });
            }

            /* ////////////////////////////////
            // override nq_answers for testing
            nq_answers = new int[nq_pids.Length];
            // generate random nq_answers
            for (int i=0; i < nq_answers.Length; i++)
                nq_answers[i] = CharismsContext.rng.Next(1, 5);     //[1, 5)
            // generate specific nq_answers
            // expected top three: craftsmanship (2, 27, 52), writing (25, 50, 75), helping (10, 35, 60)
            var target_pids = new List<int> { 2, 27, 52, 25, 50, 75, 10, 35, 60 };
            for (int i = 0; i < nq_answers.Length; i++)
            {
                if (target_pids.Contains(nq_pids[i]))
                    nq_answers[i] = CharismsContext.rng.Next(3, 5);   //3 or 4
                else
                    nq_answers[i] = CharismsContext.rng.Next(1, 3);   //1 or 2
            }
            ////////////////////////////////*/
            
            if (nq_answers.Min() < 1 || nq_answers.Max() > 4 || nq_answers.Length != nq_pids.Length)
            {
                // TakeQuiz_Message = "Quiz is incomplete. All responses are required. Please take a new quiz.";
                return RedirectToAction("Get", new { mssg = "Quiz is incomplete. All responses are required. Please take a new quiz." });
            }
            else
            {
                // score quiz in this page
                //string nq_name = newQuiz.Name;
                return RedirectToPage("QuizResult", new { nq_name, nq_pids, nq_answers });
            }
        }
    }
}
