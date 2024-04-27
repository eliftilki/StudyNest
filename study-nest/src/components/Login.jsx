import React from 'react';


function Login() {
    return (
        <div className="login">
        <div className="container">
            <div className="row justify-content-center">
            <div className="col-lg-6 col-md-12">
                <div className="login-form">
                <h3>Login</h3>
                <form>
                    <div className="form-group">
                    <label>Username</label>
                    <input type="text" className="form-control" placeholder="Username" />
                    </div>
                    <div className="form-group">
                    <label>Password</label>
                    <input type="password" className="form-control" placeholder="Password" />
                    </div>
                    <div className="form-group form-button">
                    <button type="submit" className="btn btn-primary">Login</button>
                    </div>
                </form>
                </div>
            </div>
            </div>
        </div>
        </div>
    );
}
export default Login;
