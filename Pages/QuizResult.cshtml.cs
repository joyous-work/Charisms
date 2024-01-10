using Microsoft.AspNetCore.Mvc.RazorPages;
using Charisms_2.Data;

namespace Charisms_2.Pages
{
    public class QuizResultModel : PageModel
    {
        
        public string QuizName = string.Empty;

        public SortedList<double, string> RankedGifts = default!;
              
        public void OnGet(string nq_name, int[] nq_pids, int[] nq_answers)  // input validity has been checked
        {
            QuizName = nq_name;
            List<int> gift_scores = new List<int>();
            for (int i = 0; i < CharismsContext.Gifts.Length; i++)
            {
                gift_scores.Add(0);
            }
            for (int i = 0, pid, gid; i < nq_pids.Length; i++)
            {
                pid = nq_pids[i];   // pid range [1, 75]
                gid = pid % 25;     // gig range [0, 24]
                gift_scores[gid] += nq_answers[i];
            }
            var descComparer = Comparer<double>.Create((a, b) => Comparer<double>.Default.Compare(b, a));
            RankedGifts = new SortedList<double, string>(descComparer);
            for (int i = 0; i < gift_scores.Count; i++)
            {
                RankedGifts.Add(gift_scores.ElementAt(i) + CharismsContext.rng.NextDouble(),   //break ties
                    CharismsContext.Gifts.ElementAt(i));
            }
        }
    }
}
