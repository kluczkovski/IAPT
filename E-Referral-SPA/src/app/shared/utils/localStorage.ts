export class LocalStorage {

    public getUser() {
        return JSON.parse(localStorage.getItem('ek.iapt.user'));
    }

    public saveDataLocalUser(response: any) {
        this.saveUserToken(response.accessToken);
        this.saveUser(response.userToken);
    }

    public clearUserData() {
        localStorage.removeItem('ek.iapt.token');
        localStorage.removeItem('ek.iapt.user');
    }

    public getUserToken(): string {
        return localStorage.getItem('ek.iapt.token');
    }

    public saveUserToken(token: string) {
        localStorage.setItem('ek.iapt.token', token);
    }

    public saveUser(user: string) {
        localStorage.setItem('ek.iapt.user', JSON.stringify(user))
    }

}