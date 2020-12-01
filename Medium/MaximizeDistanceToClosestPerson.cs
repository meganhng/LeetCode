public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int maxDistance = 0;
        int prevOcc = -1;
        
        for (int i = 0; i<seats.Length; i++){
            if (prevOcc == -1 && seats[i] == 0){
                maxDistance++;
            }
            else if (seats[i] == 1 && prevOcc == -1){
                prevOcc = i;
            }
            else if (seats[i] == 1 && prevOcc > -1){
                int distance = (i-prevOcc)/2;
                maxDistance = Math.Max(distance, maxDistance);
                prevOcc = i;
            }
        }
        
        maxDistance = Math.Max(maxDistance, (seats.Length - prevOcc)-1);
        
        return maxDistance;
    }
}