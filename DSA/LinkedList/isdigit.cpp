int solve(vector<int> &A) {
    vector<int> leftMax(A.size(), -1);
    vector<int> rightMax(A.size(), A.size());
    vector<int> leftMin(A.size(), -1);
    vector<int> rightMin(A.size(), A.size());
    stack<int> st;
    int mod = 1000000007;

    for(int i=0;i<A.size();i++){
        while(!st.empty() && A[st.top()]<=A[i]) st.pop();
        if(!st.empty() && A[st.top()]>A[i]) leftMax[i] = st.top();
        st.push(i);
    }
    
    st = {};
    
    for(int i=A.size()-1;i>=0;i--){
        while(!st.empty() && A[st.top()]<=A[i]) st.pop();
        if(!st.empty() && A[st.top()]>A[i]) rightMax[i] = st.top();
        st.push(i);
    }

    st = {};

    for(int i=0;i<A.size();i++){
        while(!st.empty() && A[st.top()]>=A[i]) st.pop();
        if(!st.empty() && A[st.top()]<A[i]) leftMin[i] = st.top();
        st.push(i);
    }
    
    st = {};

    for(int i=A.size()-1;i>=0;i--){
        while(!st.empty() && A[st.top()]>=A[i]) st.pop();
        if(!st.empty() && A[st.top()]<A[i]) rightMin[i] = st.top();
        st.push(i); 
    }

    long long ans = 0;
    long long left = 0, right = 0;

    for(int i=0;i<A.size();i++){
        left = i - leftMax[i];
        right = rightMax[i] - i;
        
        ans += (((left*right)%mod)*A[i])%mod;
        ans %= mod;
        
        left = i - leftMin[i];
        right = rightMin[i] - i;

        ans -= (((left*right)%mod)*A[i])%mod;
        ans += mod;
        ans %= mod;
    }
    
    return ans;
}
